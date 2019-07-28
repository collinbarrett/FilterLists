import React from 'react';
import './App.css';
import { Layout } from "./Layout";
import { Router } from "./Router";

const App: React.FC = () => {
  return (
    <Layout>
      <Router />
    </Layout>
  );
}

export default App;
