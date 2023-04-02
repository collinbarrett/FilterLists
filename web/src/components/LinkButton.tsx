import { Button } from "antd";
import { ButtonType } from "antd/lib/button";

interface Props {
  url?: string;
  text: string;
  title?: string;
  type?: ButtonType;
  icon?: React.ReactNode;
}

export const LinkButton = (props: Props) =>
  props.url && props.text ? (
    <Button
      href={props.url}
      title={props.title}
      type={props.type || "default"}
      block
      icon={props.icon}
      target="_blank"
      rel="noopener noreferrer"
    >
      {props.text}
    </Button>
  ) : null;
