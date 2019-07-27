import React from 'react';
import './App.css';
import { BrowserRouter } from "react-router-dom";
import * as RoutesModule from "./Routes";

const App: React.FC = () => {
  // const baseUrl = document.getElementsByTagName("base")[0].getAttribute("href")!;
  return (
    <BrowserRouter children={RoutesModule.Routes}  />
  );
}

export default App;
