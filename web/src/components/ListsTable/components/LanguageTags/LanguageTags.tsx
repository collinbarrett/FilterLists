import { Language } from "@/src/interfaces";
import { Popover, Tag } from "antd";

interface Props {
  languages: Language[];
}

export const LanguageTags = ({ languages }: Props) =>
  languages.length ? (
    <>
      {languages.map((l: Language, i: number) => (
        <Popover title={l.name} key={i}>
          <Tag title={l.name}>{l.iso6391}</Tag>
        </Popover>
      ))}
    </>
  ) : null;
