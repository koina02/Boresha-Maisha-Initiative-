// Smooth Scrolling for anchor links
document.querySelectorAll('a').forEach(anchor => {
    anchor.addEventListener('click', function (e) {
        // Prevent default behavior (which is jumping to the section instantly)
        e.preventDefault();

        // Scroll to the section related to the link clicked
        document.querySelector(this.getAttribute('href')).scrollIntoView({
            behavior: 'smooth',  // Scroll smoothly
            block: 'start'       // Align the element to the top of the viewport
        });
    });
});