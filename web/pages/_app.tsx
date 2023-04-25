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

const { Header, Content, Footer } = Layout;
const { darkAlgorithm } = theme;

function App({ Component, pageProps }: AppProps) {
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
        <Content className={styles.content}>
          <Component {...pageProps} />
        </Content>
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
}

export default App;
