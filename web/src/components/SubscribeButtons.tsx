import { ImportOutlined } from "@ant-design/icons";
import { Button } from "antd";
import { ButtonType } from "antd/lib/button";

interface Props {
  name: string;
  viewUrls: string[];
}

export const SubscribeButtons = (props: Props) =>
  props.viewUrls.length ? (
    <>
      <SubscribeButton
        name={props.name}
        viewUrl={props.viewUrls[0]}
        text="Subscribe"
        isPrimary={true}
      />
      <MirrorButtons
        name={props.name}
        viewUrlMirrors={props.viewUrls.slice(1)}
      />
    </>
  ) : null;

interface MirrorButtonsProps {
  name: string;
  viewUrlMirrors: string[] | undefined;
}

const MirrorButtons = (props: MirrorButtonsProps) => (
  <>
    {props.viewUrlMirrors && props.viewUrlMirrors.length
      ? props.viewUrlMirrors.map((viewUrlMirror: string, i: number) => (
          <SubscribeButton
            key={i}
            name={props.name}
            viewUrl={viewUrlMirror}
            text={`Subscribe (Mirror ${i + 1})`}
            isPrimary={false}
          />
        ))
      : null}
  </>
);

interface SubscribeButtonProps {
  name: string;
  viewUrl: string;
  text: string;
  isPrimary: boolean;
}

const SubscribeButton = (props: SubscribeButtonProps) => {
  const buttonProps = buildButtonProps(
    props.name,
    props.viewUrl,
    props.isPrimary,
  );
  return (
    <Button
      hidden={buttonProps.disabled}
      block
      icon={<ImportOutlined />}
      type={buttonProps.type}
      href={buttonProps.href}
      title={buttonProps.title}
    >
      {props.text}
    </Button>
  );
};

const buildButtonProps = (
  name: string,
  viewUrl: string,
  isPrimary: boolean,
) => {
  let type: ButtonType = isPrimary ? "primary" : "default";
  let hidden: boolean = false;

  const hrefLocation = `${encodeURIComponent(viewUrl)}`;
  const hrefTitle = `${encodeURIComponent(name)}`;
  let href = `abp:subscribe?location=${hrefLocation}&title=${hrefTitle}`;

  let prefixes: string[] = [];
  let message = `Subscribe to ${name} with a browser extension supporting the "abp:" protocol (e.g. uBlock Origin, Adblock Plus).`;

  // HTTP protocols
  if (viewUrl.includes(".onion/")) {
    type = "dashed";
    prefixes.push("TOR");
  }
  if (viewUrl.includes("http://")) {
    type = "dashed";
    prefixes.push("INSECURE");
  }

  // Software protocols
  if (viewUrl.includes(".tpl")) {
    href = `https://filterlists.com/tpl.html`;
    message = `Subscribe via FilterList's TPL page.`;
  }
  if (
    viewUrl.includes(".lsrules") ||
    viewUrl.includes("?hostformat=littlesnitch")
  ) {
    href = `x-littlesnitch:subscribe-rules?url=${hrefLocation}`;
    message = `Subscribe to ${name} with Little Snitch's rule group subscription feature.`;
  }

  // Formats
  if (
    viewUrl.includes(".zip") ||
    viewUrl.includes(".7z") ||
    viewUrl.includes(".tar.gz")
  ) {
    hidden = true; // no known software supports subscribing to compressed lists
  }

  const title = `${
    prefixes.length ? prefixes.join(" | ") + " | " : ""
  }${message}`;

  return { disabled: hidden, type, href, title };
};
