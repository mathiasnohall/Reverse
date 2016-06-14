"use strict";

services.factory('statusService', ['$log', '$http', 'CONFIG', function ($log, $http, CONFIG) {

    return {
        getStatus: function (query) {
            return $http.get(CONFIG.apiUrl + 'status/status')
                .then(function (response) {
                    return response.data;
            });
        }
    };
}]);
