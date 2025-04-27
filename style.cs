/* Reset basic styling */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

body {
    font-family: 'Poppins', sans-serif;
    background-color: #FFFFFF;
    color: #2E7D32;
    line-height: 1.6;
}

/* Header */
header {
    background-color: #4CAF50;
    color: white;
    padding: 1rem 0;
    text-align: center;
}

header h1 {
    font-weight: 800;
}

nav {
    margin-top: 10px;
}

nav a {
    color: white;
    margin: 0 10px;
    text-decoration: none;
    font-weight: 600;
}

nav a:hover {
    text-decoration: underline;
}

/* Main sections */
main {
    padding: 2rem;
}

section {
    margin: 2rem 0;
    text-align: center;
}

section h2 {
    color: #4CAF50;
    font-weight: 600;
    margin-bottom: 1rem;
}

form {
    display: flex;
    flex-direction: column;
    width: 300px;
    margin: 1rem auto;
}

input, textarea {
    margin: 10px 0;
    padding: 10px;
    border: 1px solid #4CAF50;
    border-radius: 5px;
}

button {
    padding: 10px;
    background-color: #4CAF50;
    color: white;
    border: none;
    font-weight: 600;
    cursor: pointer;
    border-radius: 5px;
}

button:hover {
    background-color: #2E7D32;
}

/* Footer */
footer {
    background-color: #4CAF50;
    color: white;
    padding: 1rem;
    text-align: center;
    margin-top: 2rem;
}

/* Responsive */
@media (max-width: 768px) {
    nav {
        display: flex;
        flex-direction: column;
    }
    form {
        width: 90%;
    }
}

#hero {
    background: url('banner.jpg') no-repeat center center/cover;
    height: 100vh;
    display: flex;
    align-items: center;
    justify-content: center;
    text-align: center;
    color: white;
    position: relative;
}

.hero-content {
    background-color: rgba(0, 0, 0, 0.5); /* subtle dark overlay */
    padding: 20px;
    border-radius: 10px;
}

.hero-content h1 {
    font-size: 2.5rem;
    margin-bottom: 1rem;
}

.hero-content p {
    font-size: 1.2rem;
    margin-bottom: 1.5rem;
}

.btn {
    background-color: #4CAF50;
    padding: 10px 20px;
    color: white;
    border: none;
    border-radius: 5px;
    text-decoration: none;
    font-weight: bold;
}

.btn:hover {
    background-color: #2E7D32;
}

