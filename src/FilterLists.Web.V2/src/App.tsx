import { Icon, Layout, Menu } from 'antd';
import React from 'react';
import { BrowserRouter as Router, Route, RouteComponentProps, Switch } from 'react-router-dom';

import { ListsTable } from './components';

const { Header, Content, Footer } = Layout;

export const App: React.FC = () =>
  <Router>
    <Layout>
      <Header>
        <Logo />
        <Menu theme="dark" mode="horizontal" style={{ lineHeight: '64px' }} />
      </Header>
      <Content>
        <div style={{ background: '#fff', paddingLeft: 12, paddingTop: 12, paddingRight: 12, minHeight: 280 }}>
          <Switch>
            <Route path="/" component={ListsTable} />
            <Route component={NotFound} />
          </Switch>
        </div>
      </Content>
      <Footer style={{ textAlign: 'center' }}>
        <CopyrightAuthor /> | <Twitter /> | <Community /> | <GitHub /> | <Api /> | <Donate />
      </Footer>
    </Layout>
  </Router>;

const Logo = () =>
  <img src={`${process.env.PUBLIC_URL}/logo_filterlists.png`}
    alt="FilterLists logo"
    height="44px"
    style={{ background: '#fff' }} />;

const NotFound = (props: RouteComponentProps) =>
  <h2>
    404 Not Found: <code>{props.location.pathname}</code>
  </h2>;

const CopyrightAuthor = () =>
  <>
    ©{new Date().getFullYear()}&nbsp;
    <a href="https://collinmbarrett.com"
      title="Collin M. Barrett's Homepage"
      target="_blank"
      rel="noopener noreferrer">
      Collin M. Barrett
    </a>
  </>;

const Twitter = () =>
  <a href="https://twitter.com/FilterLists"
    title="FilterLists on Twitter"
    target="_blank"
    rel="noopener noreferrer">
    <Icon type="twitter" /> Twitter
  </a>;

const Community = () =>
  <a href="https://hub.filterlists.com"
    title="FilterLists Discourse community forum"
    target="_blank"
    rel="noopener noreferrer">
    <Icon type="team" /> Community
  </a>;

const GitHub = () =>
  <a href="https://github.com/collinbarrett/FilterLists"
    title="FilterLists git repository on GitHub"
    target="_blank"
    rel="noopener noreferrer">
    <Icon type="github" /> GitHub
  </a>;

const Api = () =>
  <a href="/api/v1/lists"
    title="FilterLists API lists endpoint"
    target="_blank"
    rel="noopener noreferrer">
    <Icon type="api" /> API
  </a>;

const Donate = () =>
  <a href="https://beerpay.io/collinbarrett/FilterLists"
    title="Donate to FilterLists with Beerpay"
    target="_blank"
    rel="noopener noreferrer">
    <Icon type="dollar" /> Donate
  </a>;