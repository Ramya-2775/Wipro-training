const quoteElement = document.getElementById('quote');

const quotes = [
  "“The only way to do great work is to love what you do.” — Steve Jobs",
  "“Believe in yourself and all that you are.”",
  "“Push yourself, because no one else is going to do it for you.”",
  "“Don’t stop when you’re tired. Stop when you’re done.”",
  "“Success doesn’t just find you. You have to go out and get it.”"
];

let currentIndex = 0;

quoteElement.addEventListener('click', () => {
  currentIndex = (currentIndex + 1) % quotes.length;
  quoteElement.textContent = quotes[currentIndex];
});