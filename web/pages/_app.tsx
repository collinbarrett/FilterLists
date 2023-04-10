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

const { Header, Content, Footer } = Layout;

export default function App({ Component, pageProps }: AppProps) {
  return (
    <Layout>
      <Header>
        <div style={{ display: "flex" }}>
          <Logo />
          <Menu />
        </div>
      </Header>
      <Content style={{ padding: "0 50px" }}>
        <Component {...pageProps} />
      </Content>
      <Footer style={{ textAlign: "center" }}>
        <Copyright />
        <Api />
        <GitHub />
        <Twitter />
        <Donate />
      </Footer>
    </Layout>
  );
}
