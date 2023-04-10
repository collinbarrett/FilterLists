import "@/styles/globals.css";
import type { AppProps } from "next/app";
import "antd/dist/reset.css";
import React from "react";
import { Layout } from "antd";
import Logo from "@/components/logo";
import Menu from "@/components/menu";

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
        Ant Design ©2023 Created by Ant UED
      </Footer>
    </Layout>
  );
}
