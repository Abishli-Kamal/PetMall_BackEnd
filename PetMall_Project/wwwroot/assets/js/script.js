$('.slider').slick({
    dots: true,
    infinite: true,
    speed: 500,
    fade: true,
    cssEase: 'linear',
    nextArrow: $(".nextBtn"),
    prevArrow: $(".prevBtn"),
    autoplay: true,
    autoplaySpeed: 2000,
})    
$('.brands').slick({
    slidesToShow: 6,
    slidesToScroll: 1,
    dots: true,
   
})

$('.owl-carousel').owlCarousel({
    loop:true,
    margin:10,
    nav:true,
    responsive:{
        0:{
            items:1
        },
        600:{
            items:3
        },
        1000:{
            items:5
        }
    }
})

let rightBtn = document.querySelector(".right1")
let leftBtn = document.querySelector(".left1");
let images = document.querySelector(".imgs");

rightBtn.addEventListener("click",function(){
   let active = document.querySelector(".active");
    active.classList.remove("active");
    if(active.nextElementSibling!=null){
        active.nextElementSibling.classList.add("active");
    }else{
        images.firstElementChild.classList.add("active")
    }
})

leftBtn.addEventListener("click",function(){
    let active = document.querySelector(".active");
     active.classList.remove("active");
     if(active.previousElementSibling !=null){
         active.previousElementSibling.classList.add("active");
     }else{
         images.lastElementChild.classList.add("active")
     }
})

