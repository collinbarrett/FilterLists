import { Tag } from "antd";

interface Props {
  name: string;
  url?: string;
  showLabel?: boolean;
}

export const LicenseTag = (props: Props) =>
  props.name ? (
    <span>
      {props.showLabel && <h3>License:</h3>}
      <Tag>
        <TagContents name={props.name} url={props.url} />
      </Tag>
    </span>
  ) : null;

const TagContents = (props: Props) =>
  props.url ? (
    <a
      href={props.url}
      title={`View ${props.name}'s homepage.`}
      target="_blank"
      rel="noopener noreferrer"
    >
      {props.name}
    </a>
  ) : (
    <>{props.name}</>
  );
