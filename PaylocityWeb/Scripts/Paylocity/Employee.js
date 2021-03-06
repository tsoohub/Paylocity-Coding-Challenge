var Paylocity = Paylocity || {};

$(document).ready(function () {
    $('#AddEmpButton').on('click', function (e) {
        Paylocity.empFunctions.addEmp(e);
        return false;
    });

    $('.fa-info-circle').on('click', function () {
        Paylocity.empFunctions.getEmpDetails(this.id);
    });

    $('.fa-plus').on('click', function () {
        Paylocity.empFunctions.addDependentRow();
    });

    $('.action-link-modal').on('click', function (e) {
        Paylocity.empFunctions.openAddDialog(e);
    });

    $('#rowErrorMsg').on('click', function () {
        $('#rowErrorMsg').addClass('hidden');
    });
});

Paylocity.empFunctions = (function ($) {
    var addEmp = function (e) {
        if ($('#EmpForm').validate().form()) {
            var myData = $('#EmpForm').serialize();
            $('#AddEmpButton').attr('disabled', true);
            $('#loading').removeClass('hidden');
            $.ajax({
                url: Paylocity.baseUrl + 'Employee/AddEmployee',
                data: myData,
                type: 'POST'
            }).done(function (data) {

                window.location.href = Paylocity.baseUrl + 'Employee/Index';
            }).fail(function (response) {
                $('#errorMsg').removeClass('hidden');
            });
        }
    },
    getEmpDetails = function (id) {
        $.ajax({
            url: Paylocity.baseUrl + 'Employee/GetDetails',
            data: { anEmployeeId: id },
            type: 'GET'
        }).done(function (display) {
            $('#empDetails').dialog({
                autoOpen: false,
                width: 420,
                resizable: false,
                modal: true
            }).html(display);
            $("#empDetails").dialog('open');
        }).fail(function (response) {
            $('#errorMsgDetails').removeClass('hidden');
        });
    },
    addDependentRow = function () {
        // number of rows in dependents table
        var count = $('#dependents tr').length - 3;
        var row = document.getElementById('row0'); // row to clone
        var table = document.getElementById('dependents');
        var clone = row.cloneNode(true);
        clone.id = 'row' + count;
        table.appendChild(clone);

        $('#dependents tr:last input[name=\'dependents[0].Name\']').attr('name', 'dependents[' + count + '].Name').val('');
        $('#dependents tr:last select').attr('name', 'dependents[' + count + '].Type').prop('selectedIndex', 1);
    },
    removeDependentRow = function (id) {
        if (id !== 'row0') {
            $('#' + id).remove();
            renumberDependentRows();
        }
        else {
            $('#rowErrorMsg').removeClass('hidden');
        }
    },
    renumberDependentRows = function () {
        $('.dep-row').each(function (i, obj) {
            if (i != 0) {
                $(this).attr('id', 'row' + i);
            }
        });
        $('.dep-name').each(function (i, obj) {
            if (i != 0) {
                $(this).attr('name', 'dependents[' + i + '].Name');
            }
        });
        $('.dep-type').each(function (i, obj) {
            if (i != 0) {
                $(this).attr('name', 'dependents[' + i + '].Type');
            }
        });
    },
    openAddDialog = function (e) {
        e.preventDefault();
        $('#addEmp').dialog({
            autoOpen: false,
            width: 1200,
            resizable: true,
            modal: true
        });
        $('#addEmp').load(Paylocity.baseUrl + 'Employee/_AddEmployee', function () {
            $(this).dialog('open');
        });
    }

    //public functions
    return {
        addEmp: addEmp,
        getEmpDetails: getEmpDetails,
        addDependentRow: addDependentRow,
        removeDependentRow: removeDependentRow,
        renumberDependentRows:renumberDependentRows,
        openAddDialog: openAddDialog
    };
})(jQuery);