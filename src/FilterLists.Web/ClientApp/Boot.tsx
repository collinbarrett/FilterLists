import * as React from "react";
import * as ReactDOM from "react-dom";
import { AppContainer } from "react-hot-loader";
import { BrowserRouter } from "react-router-dom";
import * as RoutesModule from "./Routes";
let routes = RoutesModule.Routes;

function renderApp() {
    const baseUrl = document.getElementsByTagName("base")[0].getAttribute("href")!;
    ReactDOM.render(
        <AppContainer>
            <BrowserRouter children={ routes } basename={ baseUrl }/>
        </AppContainer>,
        document.getElementById("react-app")
    );
}

renderApp();

if (module.hot) {
    module.hot.accept("./routes",
        () => {
            routes = require<typeof RoutesModule>("./Routes").Routes;
            renderApp();
        });
}