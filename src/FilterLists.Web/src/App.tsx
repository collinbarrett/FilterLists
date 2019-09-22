import { Icon, Layout, Menu, Tag } from "antd";
import React from "react";
import {
  BrowserRouter as Router,
  Link,
  Route,
  RouteComponentProps,
  Switch
} from "react-router-dom";

import { ListsTable } from "./components";

const { Header, Content, Footer } = Layout;

export const App: React.FC = () => (
  <Router>
    <Layout>
      <Header style={{ background: "#fff" }}>
        <Logo />
        <Menu mode="horizontal" style={{ lineHeight: "64px" }} />
      </Header>
      <Content>
        <div
          style={{
            background: "#fff",
            paddingLeft: 12,
            paddingTop: 12,
            paddingRight: 12,
            minHeight: 280
          }}
        >
          <Switch>
            <Route path="/" component={ListsTable} />
            <Route component={NotFound} />
          </Switch>
        </div>
      </Content>
      <Footer
        style={{
          textAlign: "center",
          padding: "6px 50px",
          background: "#fff",
          lineHeight: "28px"
        }}
      >
        <CopyrightAuthor />
        <Twitter />
        <Community />
        <GitHub />
        <Api />
        <Donate />
      </Footer>
    </Layout>
  </Router>
);

const Logo = () => (
  <Link to="/">
    <img
      src={`${process.env.PUBLIC_URL}/logo_filterlists.png`}
      alt="FilterLists logo"
      height="44px"
      style={{ background: "#fff" }}
    />
  </Link>
);

const NotFound = (props: RouteComponentProps) => (
  <h2>
    404 Not Found: <code>{props.location.pathname}</code>
  </h2>
);

const CopyrightAuthor = () => (
  <Tag>
    ©{new Date().getFullYear()}&nbsp;
    <a
      href="https://collinmbarrett.com"
      title="Collin M. Barrett's Homepage"
      target="_blank"
      rel="noopener noreferrer"
    >
      Collin M. Barrett
    </a>
  </Tag>
);

const Twitter = () => (
  <Tag>
    <a
      href="https://twitter.com/FilterLists"
      title="FilterLists on Twitter"
      target="_blank"
      rel="noopener noreferrer"
    >
      <Icon type="twitter" /> Twitter
    </a>
  </Tag>
);

const Community = () => (
  <Tag>
    <a
      href="https://hub.filterlists.com"
      title="FilterLists Discourse community forum"
      target="_blank"
      rel="noopener noreferrer"
    >
      <Icon type="team" /> Community
    </a>
  </Tag>
);

const GitHub = () => (
  <Tag>
    <a
      href="https://github.com/collinbarrett/FilterLists"
      title="FilterLists git repository on GitHub"
      target="_blank"
      rel="noopener noreferrer"
    >
      <Icon type="github" /> GitHub
    </a>
  </Tag>
);

const Api = () => (
  <Tag>
    <a
      href="/api/v1/lists"
      title="FilterLists API lists endpoint"
      target="_blank"
      rel="noopener noreferrer"
    >
      <Icon type="api" /> API
    </a>
  </Tag>
);

const Donate = () => (
  <Tag>
    <a
      href="https://beerpay.io/collinbarrett/FilterLists"
      title="Donate to FilterLists with Beerpay"
      target="_blank"
      rel="noopener noreferrer"
    >
      <Icon type="dollar" /> Donate
    </a>
  </Tag>
);
