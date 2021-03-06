﻿"use strict";

services.factory('reverseService', ['$log', '$http', 'CONFIG', function ($log, $http, CONFIG) {

    return {
        postForm: function (data) {
            return $http.post(CONFIG.apiUrl + 'reverse/reverse', data)
                .then(function (response) {
                    return response.data;
            });
        }
    };
}]);
