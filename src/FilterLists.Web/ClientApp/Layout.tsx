import * as React from "react";
import "bootstrap";
import "./site.css";

interface IProps {
    children?: React.ReactNode;
};

export const Layout = (props: IProps) =>
    <div className="container">
        <Header/>
        <div className="row">
            <div className="w-100">
                { props.children }
            </div>
        </div>
        <Footer/>
    </div>;

const Header = () =>
    <header className="row">
        <h1>
            <a href="./">
                <img src="logo_filterlists.png" alt="FilterLists" className="img-fluid"/>
            </a>
        </h1>
    </header>;

const Footer = () =>
    <footer className="row justify-content-center">
        <p className="mt-2 ml-1 mr-1">
            <HubLink/> | <GitHubLink/> | <ApiLink/> | <DonateLink/> | By <OwnerLink/>
        </p>
    </footer>;

const HubLink = () =>
    <a href="https://hub.filterlists.com"
       title="Discourse community forum">
        Hub
    </a>;

const GitHubLink = () =>
    <a href="https://github.com/collinbarrett/FilterLists">
        GitHub
    </a>;

const ApiLink = () =>
    <a href="/api/docs/index.html"
       title="API Swagger docs">
        API
    </a>;

const DonateLink = () =>
    <a href="https://beerpay.io/collinbarrett/FilterLists"
       title="Support with Beerpay">
        Donate
    </a>;

const OwnerLink = () =>
    <a href="https://collinmbarrett.com/">
        Collin M. Barrett
    </a>;