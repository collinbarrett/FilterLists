import { Language } from "@/src/interfaces";
import { Popover, Tag } from "antd";

interface Props {
  languages: Language[];
}

export const LanguageTags = ({ languages }: Props) =>
  languages.length ? (
    <>
      {languages.map((language: Language, index: number) => (
        <Popover title={language.name} key={index}>
          <Tag title={language.name}>{language.iso6391}</Tag>
        </Popover>
      ))}
    </>
  ) : null;
