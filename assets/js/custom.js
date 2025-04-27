// Counter Animation
jQuery(document).ready(function($) {
	$('.counter').counterUp({
	  delay: 10,
	  time: 1000
	});
  
	// Smooth Scroll
	$('a[href*="#"]').on('click', function(e) {
	  e.preventDefault();
	  $('html, body').animate({
		scrollTop: $($(this).attr('href')).offset().top - 80
	  }, 500);
	});
  
	// Navbar Scroll Effect
	$(window).scroll(function() {
	  if ($(this).scrollTop() > 50) {
		$('.navbar').addClass('scrolled');
	  } else {
		$('.navbar').removeClass('scrolled');
	  }
	});
  });