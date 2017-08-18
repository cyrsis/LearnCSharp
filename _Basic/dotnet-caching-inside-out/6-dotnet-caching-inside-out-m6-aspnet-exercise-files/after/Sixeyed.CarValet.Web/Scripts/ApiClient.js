var ApiClient;
(function (ApiClient) {
    var Vehicles = (function () {
        function Vehicles() { }
        Vehicles.baseUrl = 'http://localhost/Sixeyed.CarValet.Api/api/vehicle';
        Vehicles.prototype.searchVehicles = function (makeName, modelName, successCallback) {
            var data = {
                "makeName": makeName,
                "modelName": modelName
            };
            $.getJSON(Vehicles.baseUrl, data, successCallback);
        };
        Vehicles.prototype.getVehicle = function (vehicleId, successCallback) {
            $.getJSON(Vehicles.baseUrl + "/" + vehicleId, null, successCallback);
        };
        return Vehicles;
    })();
    ApiClient.Vehicles = Vehicles;    
})(ApiClient || (ApiClient = {}));
