'use strict';

reverseApp.controller('reverseController', ['$scope', 'reverseService', function ($scope, reverseService) {
    
    $scope.submitForm = function (form) {
        reverseService.postForm(form).then(function (data) {
            $scope.response = data;
            $scope.success = true;
        }, function (reason) {
            $scope.success = false;
        });
    }
}]);