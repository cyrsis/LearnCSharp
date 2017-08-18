/// <reference path="jquery.d.ts" />

module ApiClient {

    export class Vehicles {

        static baseUrl = 'http://localhost/Sixeyed.CarValet.Api/api/vehicle';

        searchVehicles(makeName: string, modelName: string, successCallback) {
            var data = { "makeName": makeName, "modelName": modelName };
            $.getJSON(Vehicles.baseUrl, data, successCallback);
        };

        getVehicle(vehicleId, successCallback) {            
            $.getJSON(Vehicles.baseUrl + "/" + vehicleId, null, successCallback);
        };
    }
}