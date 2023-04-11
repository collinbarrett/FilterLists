import "@/styles/globals.css";
import type { AppProps } from "next/app";
import "antd/dist/reset.css";
import React from "react";
import { Layout } from "antd";
import {
  Logo,
  Copyright,
  Api,
  GitHub,
  Twitter,
  Donate,
  Menu,
} from "@/components";
import styles from "./_app.module.css";

const { Header, Content, Footer } = Layout;

export default function App({ Component, pageProps }: AppProps) {
  return (
    <Layout>
      <Header className={styles.header}>
        <Logo />
        <Menu />
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
  );
}
