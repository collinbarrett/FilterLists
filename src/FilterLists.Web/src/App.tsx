import React from 'react';
import '../node_modules/bootstrap/dist/css/bootstrap.min.css'
import './App.css';
import { BrowserRouter } from "react-router-dom";
import * as RoutesModule from "./Routes";

const App: React.FC = () => {
  return (
    <BrowserRouter children={RoutesModule.Routes} />
  );
}

export default App;
