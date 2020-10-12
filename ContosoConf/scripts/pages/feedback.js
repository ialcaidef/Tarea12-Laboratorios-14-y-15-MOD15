﻿import { StarRatingView } from "../StarRatingView.js";

const section = document.getElementById("feedback");
const form = section.querySelector("form");
const sent = document.getElementById("feedback-sent");

function formSubmitting(event) {
    event.preventDefault();
    form.classList.add("sending");
};

function animationEnded() {
    section.style.display = "none";
    sent.style.display = "block";
};

form.addEventListener("submit", formSubmitting, false);
form.addEventListener("msAnimationEnd", animationEnded, false);
form.addEventListener("webkitAnimationEnd", animationEnded, false);
form.addEventListener("animationEnd", animationEnded, false);

const questions = form.querySelectorAll(".feedback-question");
for (let i = 0; i < questions.length; i++) {
    new StarRatingView(questions[i]);
}
