import {
  ApiOutlined,
  DollarOutlined,
  GithubOutlined,
  IeOutlined,
  TeamOutlined,
  TwitterOutlined,
} from "@ant-design/icons";
import { Layout, Tag } from "antd";
import React from "react";
import {
  BrowserRouter as Router,
  Link,
  Route,
  RouteComponentProps,
  Switch,
} from "react-router-dom";

import { ListsTable } from "./components";

const { Header, Content, Footer } = Layout;

export const App: React.FC = () => (
  <Router>
    <Layout>
      <Header style={{ background: "#000" }}>
        <Logo />
      </Header>
      <Content>
        <div
          style={{
            paddingLeft: 4,
            paddingRight: 4,
            minHeight: 280,
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
        }}
      >
        <CopyrightAuthor />
        <Twitter />
        <Community />
        <GitHub />
        <Api />
        <Tpl />
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
      <TwitterOutlined /> Twitter
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
      <TeamOutlined /> Community
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
      <GithubOutlined /> GitHub
    </a>
  </Tag>
);

const Api = () => (
  <Tag>
    <a
      href="/api"
      title="FilterLists API"
      target="_blank"
      rel="noopener noreferrer"
    >
      <ApiOutlined /> API
    </a>
  </Tag>
);

const Tpl = () => (
  <Tag>
    <a
      href="/tpl.html"
      title="FilterLists Tracking Protection Lists (TPL) for Internet Explorer"
    >
      <IeOutlined /> TPL (IE)
    </a>
  </Tag>
);

const Donate = () => (
  <Tag>
    <a
      href="https://github.com/sponsors/collinbarrett"
      title="Sponsor Collin Barrett on GitHub"
      target="_blank"
      rel="noopener noreferrer"
    >
      <DollarOutlined /> Donate
    </a>
  </Tag>
);
