import { Tag } from "antd";
import { Language } from "../../interfaces/Language";

interface Props {
  languages: Language[];
  showLabel?: boolean;
}

export const LanguageCloud = (props: Props) =>
  props.languages && props.languages.length ? (
    <div>
      {props.showLabel && (
        <h3>{`Language${props.languages.length > 1 ? "s" : ""}:`}</h3>
      )}
      {props.languages.map((l: Language, i: number) => (
        <Tag key={i} title={l.name}>
          {l.iso6391}
        </Tag>
      ))}
    </div>
  ) : null;
