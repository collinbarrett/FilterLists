import { InfoCircleOutlined } from "@ant-design/icons";
import { Button } from "antd";
import React from "react";
import { RouteComponentProps } from "react-router-dom";
import slugify from "slugify";

import { SlugifyOptions } from "../constants";

interface Props {
  listName: string;
}

export const ListInfoButton = (props: RouteComponentProps & Props) => {
  const listPath = `/lists/${slugify(props.listName, SlugifyOptions)}`;
  return (
    <Button
      type="primary"
      title={`View more information about ${props.listName}.`}
      onClick={() =>
        props.location.pathname === listPath
          ? props.history.push("/")
          : props.history.push(listPath)
      }
    >
      <InfoCircleOutlined />
    </Button>
  );
};
