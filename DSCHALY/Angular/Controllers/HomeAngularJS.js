var app = angular.module("Homeapp", []);

app.controller("HomeController", function ($scope, $http, $window) {
    $scope.btntext = "Save";

    // GET
    $http.get("/Home/Get_Data").then(function (d) {
        $scope.register = d.data;
    }, function (error) {
        alert('Failed!');
    });

    // GET BY ID
    $scope.loadrecord = function (id) {
        $http.get("/Home/Get_Data_By_Id?id="+id).then(function (d) {
            $scope.register = d.data;
        }, function (error) {
            alert('Failed!');
        });
    };

    // SAVE
    $scope.savedata = function () {
        $scope.btntext = "Please Wait...";
        $http({
            method: 'POST',
            url: '/Home/Test',
            data: $scope.register
        }).then(function (d) {
            $scope.btntext = "Save";
            $scope.register = null;
            alert('Success!');

            $window.location.href = '/Home/Show_Data';
            
        }, function (error) {
            alert('Failed!');
        })
    }

    // UPDATE
    $scope.updatedata = function () {
        $scope.btntext = "Please Wait...";
        $http({
            method: 'POST',
            url: '/Home/Test',
            data: $scope.register
        }).then(function (d) {
            $scope.btntext = "Update";
            $scope.register = null;
            alert('Success!');
        }, function (error) {
            alert('Failed!');
        })
    }

    // DELETE
    $scope.deleterecord = function () {
        $http.get("/Home/Test").then(function (d) {
            //$scope.register = d.data;
            alert('Deleted!');
        }, function (error) {
            alert('Failed!');
        });
    };

});