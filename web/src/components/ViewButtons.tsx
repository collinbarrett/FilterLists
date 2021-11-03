import { LinkButton } from "./LinkButton";
import { SearchOutlined } from "@ant-design/icons";

interface Props {
  name: string;
  viewUrls: string[];
}

export const ViewButtons = (props: Props) =>
  props.viewUrls.length ? (
    <>
      <ViewButton name={props.name} viewUrl={props.viewUrls[0]} text="View" />
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
          <ViewButton
            key={i}
            name={props.name}
            viewUrl={viewUrlMirror}
            text={`View (Mirror ${i + 1})`}
          />
        ))
      : null}
  </>
);

interface ViewButtonProps {
  name: string;
  viewUrl: string;
  text: string;
}

const ViewButton = (props: ViewButtonProps) => {
  return (
    <LinkButton
      url={props.viewUrl}
      text={props.text}
      title={`View ${props.name} in its raw format`}
      icon={<SearchOutlined />}
    />
  );
};
