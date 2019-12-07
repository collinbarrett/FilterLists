import { Button } from "antd";
import { ButtonType } from "antd/lib/button";
import React from "react";

interface Props {
  url: string;
  text: string;
  title?: string;
  type?: ButtonType;
  icon?: string;
}

export const LinkButton = (props: Props) =>
  props.url && props.text ? (
    <Button
      href={props.url}
      title={props.title}
      type={props.type || "default"}
      block
      style={{ borderLeftColor: "rgb(217, 217, 217)" }} //HACK: override buggy style in antd
      icon={props.icon}
      target="_blank"
      rel="noopener noreferrer"
    >
      {props.text}
    </Button>
  ) : null;
