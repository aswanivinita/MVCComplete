$(document).ready(function () {
    //var tableElement = $('#employee-table');
    var nameElement = $('#name');
    var salaryElement = $('#salary');
    var idElement = $('#employee-id');
    var tableBodyElement = $('#employee-tablebody');

    var createbtn = $('#create-btn');
    var updatebtn = $('#update-btn');
    var cancelbtn = $('#cancel-btn');

    var employees = [];

    //IIFY immediately invokable function expression
    (function () {
        getEmployees();

        updateButtonDisplay(true, false, false);
        createbtn.on('click', createEmployee);
        updatebtn.on('click', updateEmployee);
        cancelbtn.on('click', cancel);

        addEvents();
    })();

    function getEmployees() {
        $.ajax({
            method: "GET",
            url: "/home/GetAllRecords",
            success: function (data) {
                employees = data;
                populateTable();
            }
        });
    }

    function updateButtonDisplay(showCreate, showUpdate, showCancel) {
        showCreate ? createbtn.show() : createbtn.hide();
        showUpdate ? updatebtn.show() : updatebtn.hide();
        showCancel ? cancelbtn.show() : cancelbtn.hide();
    }

    function addEvents() {
        $('.employee-id').each(function () {
            $(this).on('click', onEdit);
        });

        $('.glyphicon-trash').each(function () {
            $(this).on('click', onDelete);
        });
    }

    function populateTable() {
        tableBodyElement.empty();
        employees.forEach(function (item, index) {
            var row = '<tr><td><span class="employee-id" data-id="' + item.Id + '">' + item.Id + '</span></td><td>' + item.Name + '</td><td>' + item.Salary + '</td><td><i class="glyphicon glyphicon-trash" data-id="' + item.Id + '"></i></td></tr>';
            tableBodyElement.append(row);
        });
        addEvents();
    }

    function onEdit() {
        var id = $(this).attr('data-id');

        employees.forEach(function (item, index) {
            if (item.Id == id) {
                nameElement.val(item.Name);
                salaryElement.val(item.Salary);
                idElement.val(item.Id);
                updateButtonDisplay(false, true, true);
                return 0;
            }
        });
    }


    function createEmployee() {
        $.ajax({
            method: "POST",
            data: { name: nameElement.val(), salary: salaryElement.val() },
            url: "/home/save",
            success: function (data) {
                employees.push(data);
                cancel();
                populateTable();
            }
        });
    }

    function updateEmployee() {
        $.ajax({
            method: "POST",
            data: { id: idElement.val(), name: nameElement.val(), salary: salaryElement.val() },
            url: "/home/save",
            success: function (data) {
                cancel();
                getEmployees();
            }
        });
    }

    function onDelete() {
        var id = $(this).attr('data-id');
        $.ajax({
            method: "GET",
            url: "/home/delete?id=" + id,
            success: function (data) {
                getEmployees();
            }
        });
    }

    function cancel() {
        nameElement.val('');
        salaryElement.val('');
        updateButtonDisplay(true, false, false);
    }

    $.ajaxSetup({
        beforeSend: function () {
            $('#loader').show();
        },
        complete: function () {
            $('#loader').hide();
        }
    });
});