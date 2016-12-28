/// <reference path="https://ajax.googleapis.com/ajax/libs/angularjs/1.4.3/angular.min.js" />

app = angular
    .module("myModule", [])
    .controller("myController", function ($scope, $http) {
        $http.get('http://rest-service.guides.spring.io/greeting')
        .then(function (response) {
            $scope.greeting = response.data;
        });
    });
