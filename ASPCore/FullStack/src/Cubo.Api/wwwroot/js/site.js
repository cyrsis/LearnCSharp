// Write your Javascript code.
$(function() {
    init();
    function init() {

        ko.applyBindings(new ViewModel());
    };

    function ViewModel() {
        var self = this;
        self.buckets = ko.observableArray([]);
        self.bucket = ko.observable(new BucketViewModel("", []));
        self.bucketName = ko.observable("");
        self.itemKey = ko.observable("");
        self.itemValue = ko.observable("");

        self.getBucket = function(bucketName) {
            $.get("api/buckets/" + bucketName, function(response) {
                self.bucket(new BucketViewModel(response.name, response.items));
            })
        }

        self.getItem = function(key) {
            $.get("api/buckets/" + self.bucket().name() + "/items/" + key, function(response) {
                alert(response.value);
            })
        }

        self.createBucket = function() {
            var bucketName = self.bucketName();
            $.post("api/buckets/" + bucketName, function(response) {
                self.bucketName("");
                self.buckets.push(bucketName);
            })
        }        

        self.createItem = function() {
            var bucketName = self.bucket().name();
            var key = self.itemKey();
            var value = self.itemValue();
            $.ajax({
                type: 'POST',
                url: 'api/buckets/' + bucketName + '/items',
                contentType: 'application/json',
                data:  JSON.stringify({ key, value }),
                success: function(response) {
                    self.bucket().items.push(key);
                    self.itemKey("");
                    self.itemValue("");
                }
            });
        }
        
        self.bucketSelected = ko.computed(function() {
            return self.bucket().name() != "";
        })

        self.hasBucketName = ko.computed(function() {
            return self.bucketName() != "";
        })

        loadBuckets();
        function loadBuckets() {
            $.get("api/buckets", function(response) {
                self.buckets(response);
            })
        }
    }

    function BucketViewModel(name, items) {
        this.name = ko.observable(name);
        this.items = ko.observableArray(items);
    }
})();