import { Layout, Menu } from 'antd';
import React from 'react';
import { AllListsTable } from './modules';

const { Header, Content, Footer } = Layout;

const App: React.FC = () => {
  return (
    <Layout>
      <Header>
        <div className="logo" />
        <Menu
          theme="dark"
          mode="horizontal"
          style={{ lineHeight: '64px' }}
        />
      </Header>
      <Content style={{ padding: '0 50px' }}>
        <div style={{ background: '#fff', padding: 24, minHeight: 280 }}>
          <AllListsTable />
        </div>
      </Content>
      <Footer style={{ textAlign: 'center' }}>©2019 Collin M. Barrett</Footer>
    </Layout>
  );
}

export default App;