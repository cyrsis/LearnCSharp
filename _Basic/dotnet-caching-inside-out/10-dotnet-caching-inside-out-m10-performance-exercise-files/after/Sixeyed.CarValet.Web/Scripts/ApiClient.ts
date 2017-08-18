/// <reference path="jquery.d.ts" />

module ApiClient {

    export class Vehicles {

        static localUrl = 'http://localhost/Sixeyed.CarValet.Api/api/vehicle';

        static crossDomainUrl = 'http://valetmymotor.api/Sixeyed.CarValet.Api/api/vehicle';

        searchVehicles(makeName: string, modelName: string, successCallback) {
            var data = { "makeName": makeName, "modelName": modelName };
            $.getJSON(Vehicles.localUrl, data, successCallback);
        };

        getVehicle(vehicleId, successCallback) {            
            $.getJSON(Vehicles.crossDomainUrl + "/" + vehicleId, null, successCallback);
        };
    }
}