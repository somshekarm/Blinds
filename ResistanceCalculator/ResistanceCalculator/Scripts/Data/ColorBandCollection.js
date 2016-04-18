/// <reference path="../angular.min.js" />
var myApp = angular.module("ohmCalculatorModule", []);
var ohmCalculatorController = myApp.controller("ohmCalculatorController", function ($scope, $http) {
    $http.get('http://localhost:61734/api/resistancecalculatorapi').then(function (response) {
        $scope.colorBandCollection = response.data;        
    });

    $scope.bandAColor;
    $scope.bandBColor;
    $scope.bandCColor;
    $scope.bandDColor;

    $scope.selectedColor = function (item,name) {
        switch (name) {
            case "A":
                $scope.bandAColor =  { Name: name, ColorBands: [item ]};
                break;
            case "B":
                $scope.bandBColor = { Name: name, ColorBands: [item] };
                break;
            case "C":
                $scope.bandCColor = { Name: name, ColorBands: [item] };
                break;
            case "D":
                $scope.bandDColor = { Name: name, ColorBands: [item] };
                break;
        }
    };

    

    $scope.calculateOhmValue = function () {        

        if ($scope.bandAColor == undefined || $scope.bandBColor == undefined || $scope.bandCColor == undefined || $scope.bandDColor == undefined)
            return;
        else {

            var dataCollection = [$scope.bandAColor, $scope.bandBColor, $scope.bandCColor, $scope.bandDColor];         
        
            $http.post('http://localhost:61734/api/resistancecalculatorapi',dataCollection).then(function (response) {
                $scope.ohmValue = response.data;
            });
        };
    };   
});