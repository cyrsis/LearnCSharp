$("#frameImage").ready(function () {
    curId = "frameImage";
    alternativeId = "frameImage1";
    ImageLoaded();
});

function ImageLoaded() {
    SwapImages();
    setTimeout(RefreshImage, 400);
}

function SwapImages() {

    if ($("#" + alternativeId).length) {

        $("#" + alternativeId).attr("style", "visibility: visible; position: absolute; opacity: 0; height: 10%");

        setTimeout(SwapOpacity, 100);
    }
}

function SwapOpacity() {

    $("#" + alternativeId).attr("style", "visibility: visible; opacity: 1; height: 100%");
    $("#" + curId).remove();

    var temp = curId;
    curId = alternativeId;
    alternativeId = temp;

}

function RefreshImage() {

    if (ShouldContinue()) {

        var stage = GetStage() + 1;
        var src = ConstructImageSource(stage);
        var img =
            $("<img />")
            .attr("id", alternativeId)
            .attr("style", "visibility: hidden; height: 10%")
        $("#" + curId).parent().append(img);
        img.ready(ImageLoaded).attr("src", src);

    }

}

function ShouldContinue() {
    return GetStage() <= 19;
}

function GetStage() {

    var path = $("#" + curId).attr("src");
    var pos = path.indexOf("?stage=");
    var stage = 0;

    if (pos >= 0)
        stage = parseInt(path.substring(pos + "?stage=".length));

    return stage;

}

function ConstructImageSource(stage) {
    var path = $("#" + curId).attr("src");
    var pos = path.indexOf("?");
    if (pos >= 0)
        path = path.substring(0, pos);
    return path + "?stage=" + stage;
}