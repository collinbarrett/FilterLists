import { Layout, Menu } from 'antd';
import React from 'react';

import { AllListsTable } from './modules';

const { Header, Content, Footer } = Layout;

const App: React.FC = () => {
  return (
    <Layout>
      <Header>
        <img src="logo_filterlists.png" alt="FilterLists logo" height="44px" style={{ background: '#fff' }} />
        <Menu
          theme="dark"
          mode="horizontal"
          style={{ lineHeight: '64px' }}
        />
      </Header>
      <Content>
        <div style={{ background: '#fff', paddingLeft: 12, paddingTop: 12, paddingRight: 12, minHeight: 280 }}>
          <AllListsTable />
        </div>
      </Content>
      <Footer style={{ textAlign: 'center' }}>©{(new Date()).getFullYear()} Collin M. Barrett</Footer>
    </Layout>
  );
}

export default App;