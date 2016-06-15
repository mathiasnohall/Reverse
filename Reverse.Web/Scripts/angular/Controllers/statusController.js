'use strict';

reverseApp.controller('statusController', ['$scope', 'statusService', function ($scope, statusService) {

    $scope.getStatus = function () {

        statusService.getStatus().then(function () {
            $scope.greeting = 'Hola reverse!';
        }, function (reason) {
            $scope.greeting = 'Sorry something bad happened :(';
        });
    };

    $scope.getStatus();

}]);