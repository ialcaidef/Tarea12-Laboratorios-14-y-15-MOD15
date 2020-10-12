addEventListener("message", function (event) {
    const imageData = event.data;
    let pixels = imageData.data;
    for (let i = 0; i < pixels.length; i += 4) {
        grayscalePixel(pixels, i);
    }
    postMessage({ done: imageData });
});

function grayscalePixel(pixels, index) {
    const brightness = 0.34 * pixels[index] + 0.5 * pixels[index + 1] + 0.16 * pixels[index + 2];

    pixels[index] = brightness; // red
    pixels[index + 1] = brightness; // green
    pixels[index + 2] = brightness; // blue
};
