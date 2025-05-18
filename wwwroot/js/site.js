// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const images = [
    "/images/Colab-photo.jpg",
    "/images/union-nike-jordan-sneaker-collab.jpg",
    "/images/yeezy-adidas-header.jpg"
];

let currentIndex = 0;
const imgElement = document.querySelector(".image");

document.querySelector(".left").addEventListener("click", () => {
    currentIndex = (currentIndex - 1 + images.length) % images.length;
    imgElement.src = images[currentIndex];
});

document.querySelector(".right").addEventListener("click", () => {
    currentIndex = (currentIndex + 1) % images.length;
    imgElement.src = images[currentIndex];
});