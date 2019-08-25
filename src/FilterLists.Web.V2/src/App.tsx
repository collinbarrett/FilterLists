import { Layout, Menu } from 'antd';
import React from 'react';
import { BrowserRouter, Route, RouteComponentProps, Switch } from 'react-router-dom';

import { AllListsTable } from './components';

const { Header, Content, Footer } = Layout;

export const App: React.FC = () =>
  <BrowserRouter>
    <Layout>
      <Header>
        <Logo />
        <Menu theme="dark" mode="horizontal" style={{ lineHeight: '64px' }} />
      </Header>
      <Content>
        <div style={{ background: '#fff', paddingLeft: 12, paddingTop: 12, paddingRight: 12, minHeight: 280 }}>
          <Switch>
            <Route path="/" exact component={AllListsTable} />
            <Route component={NotFound} />
          </Switch>
        </div>
      </Content>
      <Footer style={{ textAlign: 'center' }}>
        <CopyrightAuthor /> | <Community /> | <GitHub /> | <Api /> | <Donate />
      </Footer>
    </Layout>
  </BrowserRouter>;

const Logo = (): JSX.Element =>
  <img src={`${process.env.PUBLIC_URL}/logo_filterlists.png`}
    alt="FilterLists logo"
    height="44px"
    style={{ background: '#fff' }} />;

const NotFound = (props: RouteComponentProps): JSX.Element =>
  <h2>
    404 Not Found: <code>{props.location.pathname}</code>
  </h2>;

const CopyrightAuthor = (): JSX.Element =>
  <span>
    ©{new Date().getFullYear()}&nbsp;
    <a href="https://collinmbarrett.com"
      title="Collin M. Barrett's Homepage"
      target="_blank" rel="noopener noreferrer">
      Collin M. Barrett</a>
  </span>;

const Community = (): JSX.Element =>
  <a href="https://hub.filterlists.com"
    title="FilterLists Discourse community forum"
    target="_blank" rel="noopener noreferrer">
    Community
    </a>;

const GitHub = (): JSX.Element =>
  <a href="https://github.com/collinbarrett/FilterLists"
    title="FilterLists git repository on GitHub"
    target="_blank" rel="noopener noreferrer">
    GitHub
    </a>;

const Api = (): JSX.Element =>
  <a href="/api/v1/lists"
    title="FilterLists API lists endpoint"
    target="_blank" rel="noopener noreferrer">
    API
    </a>;

const Donate = (): JSX.Element =>
  <a href="https://beerpay.io/collinbarrett/FilterLists"
    title="Donate to FilterLists with Beerpay"
    target="_blank" rel="noopener noreferrer">
    Donate
    </a>;