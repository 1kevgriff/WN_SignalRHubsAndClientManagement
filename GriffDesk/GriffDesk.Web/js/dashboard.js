(function (window, undefined) {

    function openNewTicketDialog() {
    }

    function deleteTicket(ticket) {
    }

    function editTicket(ticket) {
    }
   
    var dashboardViewModel = {
        openTickets: ko.observableArray(),
        cmdNewTicket: openNewTicketDialog,
        cmdDeleteTicket: deleteTicket,
        cmdEditTicket: editTicket
    };

    ko.applyBindings(dashboardViewModel);

})(window);