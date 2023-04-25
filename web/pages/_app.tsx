import { RelayEnvironmentProvider } from "react-relay";
import { initRelayEnvironment } from "../src/RelayEnvironment";
import { RecordSource } from "relay-runtime";
import { useMemo, useEffect } from "react";
import { RelayPageProps } from "../src/relay-types";
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

function App({ Component, pageProps }: AppProps<RelayPageProps>) {
  const { theme, setDarkTheme } = useTheme();
  const environment = useMemo(initRelayEnvironment, []);

  useEffect(() => {
    const store = environment.getStore();

    // Hydrate the store.
    store.publish(new RecordSource(pageProps.initialRecords));

    // Notify any existing subscribers.
    store.notify();
  }, [environment, pageProps.initialRecords]);

  return (
    <RelayEnvironmentProvider environment={environment}>
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
    </RelayEnvironmentProvider>
  );
}

export default App;
