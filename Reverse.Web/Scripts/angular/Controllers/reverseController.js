'use strict';

reverseApp.controller('reverseController', ['$scope', 'reverseService', function ($scope, reverseService) {
    
    $scope.submitForm = function (formData) {
        reverseService.postForm(formData).then(function (data) {
            $scope.response = data;
        });
    }
}]);