import Header from "./components/Header";
import Footer from "./components/Footer";
import Todos from "./components/Todos";
import apiAction from "./api/apiAction";
import Home from "./components/Home";

export default () => {
    pageBuild();
    
};

function pageBuild(){
    header();
    footer();
    navTodos();
    navHome();
}

function header(){
    const header = document.getElementById("header");
    header.innerHTML = Header();
    
}

function footer(){
    const footer = document.getElementById("footer");
    footer.innerHTML = Footer();
}

function navHome(){
    const homeButton = document.querySelector(".nav_home");
    homeButton.addEventListener("click", function(){
        document.querySelector("#app").innerHTML = Home();
    });
}

function navTodos(){
    const toDosButton = document.querySelector(".nav_toDos");
    toDosButton.addEventListener("click", function(){
        apiAction.getRequest("https://localhost:44327/api/todos", toDos => {
            document.querySelector("#app").innerHTML = Todos(toDos);
        });
    });
}