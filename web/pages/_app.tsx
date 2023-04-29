import "@/styles/globals.css";
import type { AppProps } from "next/app";
import "antd/dist/reset.css";
import React from "react";
import { ConfigProvider, Layout, Space, Switch, theme } from "antd";
import {
  Logo,
  Copyright,
  Api,
  GitHub,
  Twitter,
  Donate,
  Menu,
} from "@/src/components";
import styles from "./_app.module.css";
import { useTheme } from "@/src/hooks";
import { coalesceToArray } from "@/src/utils";
import { ApolloClient, ApolloProvider, InMemoryCache } from "@apollo/client";

const { Header, Content, Footer } = Layout;
const { darkAlgorithm } = theme;
const client = new ApolloClient({
  uri: process.env.NEXT_PUBLIC_FILTERLISTS_API_URL,
  cache: new InMemoryCache(),
});

const App = ({ Component, pageProps }: AppProps) => {
  const { theme, setDarkTheme } = useTheme();
  return (
    <ConfigProvider theme={theme}>
      <Layout>
        <Header className={styles.header}>
          <Logo />
          <Menu />
          <Space>
            <Switch
              checkedChildren="🌛"
              unCheckedChildren="🔆"
              onChange={(checked) => setDarkTheme(checked)}
              checked={coalesceToArray(theme.algorithm)?.includes(
                darkAlgorithm
              )}
            />
          </Space>
        </Header>
        <ApolloProvider client={client}>
          <Content className={styles.content}>
            <Component {...pageProps} />
          </Content>
        </ApolloProvider>
        <Footer className={styles.footer}>
          <Copyright />
          <Api />
          <GitHub />
          <Twitter />
          <Donate />
        </Footer>
      </Layout>
    </ConfigProvider>
  );
};

export default App;
