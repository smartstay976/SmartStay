/* ================= SLIDESHOW BANNER ================= */

.slideshow-container {
    width:  100%;
    height: 450px;
    position: relative;
    overflow: hidden;
}

/* Images */
.slideshow-container img {
    position: absolute;
    width: 100%;
    height: 100%;
    object-fit: cover;
    top: 0;
    left: 0;
    opacity: 0;
    animation: fadeAnimation 9s infinite;
}

/* Delay for each image */
.slideshow-container img:nth-child(1) { animation-delay: 0s; }
.slideshow-container img:nth-child(2) { animation-delay: 3s; }
.slideshow-container img:nth-child(3) { animation-delay: 6s; }
.slideshow-container img:nth-child(4) { animation-delay: 9s; }

/* Fade Animation */
@keyframes fadeAnimation {
    0% { opacity: 0; }
    10% { opacity: 1; }
    30% { opacity: 1; }
    40% { opacity: 0; }
    100% { opacity: 0; }
}

/* Overlay Content */
.banner-overlay {
    position: absolute;
    inset: 0;
    background: rgba(0,0,0,0.45);
    display: flex;
    align-items: center;
    justify-content: center;
    text-align: center;
    padding: 20px;
    color: white;
}

.banner-box {
    max-width: 750px;
}

.banner-box h1 {
    font-size: 40px;
    margin-bottom: 15px;
    text-shadow: 0 3px 6px rgba(0,0,0,0.5);
}

.banner-box p {
    font-size: 18px;
    margin-bottom: 25px;
}

.banner-btn {
    display: inline-block;
    padding: 10px 22px;
    border-radius: 6px;
    text-decoration: none;
    font-weight: bold;
    margin: 5px;
}

.btn-orange {
    background: #ff9800;
    color: white;
}

.btn-white {
    background: white;
    color: #ff9800;
}

/* ================= ABOUT ================= */

.about-dynamic-section {
    padding: 80px 25px;
    background: linear-gradient(120deg, #ffffff, #f4f8ff);
}
 
.about-wrapper {
    display: flex;
    flex-wrap: wrap;
    align-items: center;
    gap: 40px;
    max-width: 1200px;
    margin: auto;
}
 
/* Left Content */
.about-content {
    flex: 1;
}
 
.about-content h2 {
    font-size: 42px;
    color: #1a237e;
    margin-bottom: 15px;
}
 
.about-content p {
    font-size: 17px;
    color: #555;
    line-height: 1.7;
    margin-bottom: 20px;
}
 
/* Highlight Boxes */
.about-highlights {
    display: flex;
    flex-wrap: wrap;
    gap: 15px;
}
 
.highlight-box {
    background: white;
    padding: 15px 18px;
    border-radius: 12px;
    box-shadow: 0 6px 15px rgba(0,0,0,0.08);
    transition: 0.3s ease;
    width: 180px;
}
 
.highlight-box:hover {
    transform: translateY(-6px);
}
 
.highlight-box span {
    font-size: 26px;
    font-weight: bold;
    color: #ff9800;
}
 
.highlight-box p {
    margin: 0;
    font-size: 14px;
    color: #666;
}
 
/* Right Visual Card */
.about-visual {
    flex: 1;
    background: linear-gradient(135deg, #ff9800, #ff5722);
    padding: 40px;
    border-radius: 20px;
    color: white;
    text-align: center;
    box-shadow: 0 10px 30px rgba(0,0,0,0.15);
}
 
.about-visual h3 {
    font-size: 26px;
    margin-bottom: 10px;
}
 
.about-visual ul {
    list-style: none;
    padding: 0;
}
 
.about-visual li {
    padding: 8px 0;
    font-size: 15px;
}
 
/* Responsive */
@media(max-width: 768px){
    .about-wrapper {
        flex-direction: column;
    }
}
.about-section {
    padding: 70px 30px;
    background: white;
    text-align: center;
}

.about-section h2 {
    font-size: 45px;
    color: #333;
}

.about-section p {
    max-width: 800px;
    margin: auto;
    color: #555;
    font-size: 18px;
}

/* ================= SERVICES ================= */

.services-section {
    padding: 50px 20px;
    background: #fafafa;
    text-align: center;
}

.services-section h2 {
    font-size: 32px;
    margin-bottom: 35px;
    color: #333;
}

.service-cards {
    display: flex;
    flex-wrap: wrap;
    justify-content: center;
    gap: 20px;
}

.service-card {
    width: 280px;
    background: white;
    padding: 20px;
    border-radius: 12px;
    box-shadow: 0 6px 15px rgba(0,0,0,0.08);
    transition: 0.3s ease;
}

.service-card:hover {
    transform: translateY(-8px);
}

.service-card h3 {
    color: #ff9800;
    margin: 10px 0;
}

.service-card a {
    background: #ff9800;
    color: white;
    padding: 8px 16px;
    border-radius: 6px;
    text-decoration: none;
    display: inline-block;
    margin-top: 15px;
}

/* ================= RESPONSIVE ================= */

@media (max-width: 768px) {
    .banner-box h1 {
        font-size: 28px;
    }
    .banner-box p {
        font-size: 16px;
    }
}
.pg-rating-section {
    padding: 60px 20px;
    background: #f9fbff;
    text-align: center;
}
 
.pg-rating-section h2 {
    font-size: 32px;
    margin-bottom: 40px;
    color: #333;
}
 
.rating-grid {
    display: flex;
    flex-wrap: wrap;
    justify-content: center;
    gap: 20px;
}
 
.rating-card {
    width: 300px;
    background: #ffffff;
    padding: 20px;
    border-radius: 14px;
    text-align: left;
    box-shadow: 0 4px 15px rgba(0,0,0,0.08);
    transition: 0.3s ease;
}
 
.rating-card:hover {
    transform: translateY(-6px);
}
 
.pg-name {
    font-size: 18px;
    font-weight: bold;
    color: #0063c7;
}
 
.stars {
    color: #ffb400;
    font-size: 20px;
    margin: 5px 0;
}
 
.comment {
    font-size: 15px;
    color: #555;
    margin: 8px 0 12px;
}
 
.reviewer {
    font-size: 14px;
    color: #888;
}

/*=====Footer===*/
.tab-container {
        font-family: Arial, sans-serif;
        text-align: center;
        padding: 40px 0;
    }

    /* Hide radio buttons */
    .tab-container input[type="radio"] {
        display: none;
    }

    /* Buttons for cities */
    .tab-label {
        display: inline-block;
        padding: 12px 22px;
        margin: 8px;
        background: #f1f1f1;
        color: #444;
        border-radius: 8px;
        font-size: 17px;
        cursor: pointer;
        transition: 0.3s;
        border: 2px solid transparent;
        box-shadow: 0px 3px 6px rgba(0,0,0,0.1);
    }

    .tab-label:hover {
        background: #e1eaff;
        color: #0063c7;
    }

    /* Active button */
    input[type="radio"]:checked + label {
        background: #007bff;
        color: white;
        border-color: #005fcc;
        font-weight: bold;
        box-shadow: 0px 3px 10px rgba(0,0,0,0.2);
    }

    /* Hide all content */
    .tab-content {
        display: none;
        margin-top: 35px;
        animation: fadeIn 0.4s ease-in-out;
    }

    /* Fade animation */
    @keyframes fadeIn {
        from {opacity: 0; transform: translateY(15px);}
        to {opacity: 1; transform: translateY(0);}
    }

    /* Show selected content */
    #bang-tab:checked ~ #bang-content,
    #chen-tab:checked ~ #chen-content,
    #coimb-tab:checked ~ #coimb-content,
    #delhi-tab:checked ~ #delhi-content,
    #gurg-tab:checked ~ #gurg-content,
    #hyd-tab:checked ~ #hyd-content,
    #noida-tab:checked ~ #noida-content,
    #pune-tab:checked ~ #pune-content {
        display: block;
    }

    /* Grid layout for PG items */
    .grid {
        display: grid;
        grid-template-columns: 25% 25% 25% 25%;
        gap: 18px;
        max-width: 900px;
        margin: 0 auto;
    }

    /* Card styling */
    .grid-item {
        background: white;
        padding: 14px;
        border-radius: 10px;
        font-size: 15px;
        color: #333;
        border: 1px solid #dce6f7;
        box-shadow: 0px 2px 8px rgba(0,0,0,0.08);
        transition: 0.3s;
        text-align: center;
    }

    .grid-item:hover {
        background: #007bff;
        color: white;
        transform: scale(1.05);
        box-shadow: 0px 5px 14px rgba(0,0,0,0.2);
    }

    h3 {
        color: #222;
        margin-bottom: 20px;
        font-size: 22px;
    }
.footer-bg {
    background: #d6f3ff;
    padding: 60px 40px 30px;
    font-family: Arial, sans-serif;
    width: 100%;
    clip-path: polygon(0 0, 100% 10%, 100% 100%, 0 100%);
    margin-top: 70px;
}

.footer-container {
    max-width: 1200px;
    margin: auto;
    display: grid;
    grid-template-columns: 25% 25% 25% 25%;
    color: #2d2d2d;
}

.footer-title {
    font-size: 20px;
    font-weight: bold;
    margin-bottom: 15px;
}

.footer-item {
    margin-bottom: 8px;
    cursor: pointer;
    font-size: 15px;
}

.footer-item:hover {
    color: #007aff;
}

.footer-logo {
    font-size: 33px;
    font-weight: bold;
}

.social-icons i {
    font-size: 20px;
    margin-right: 10px;
    cursor: pointer;
}

.copyright {
    text-align: center;
    margin-top: 30px;
    font-size: 14px;
    color: #444;
    border-top: 1px solid #aad8f2;
    padding-top: 10px;
}

.social-icons a {
    font-size: 22px;
    margin-right: 12px;
    color: #444;
    transition: 0.3s;
}

.social-icons a:hover {
    color: #007bff;
    transform: scale(1.2);
}