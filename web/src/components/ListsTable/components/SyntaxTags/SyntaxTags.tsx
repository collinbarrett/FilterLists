import { Syntax } from "@/src/interfaces";
import { Popover, Tag } from "antd";
import { PopoverContent } from "./PopoverContent";

interface Props {
  syntaxes: Syntax[];
}

export const SyntaxTags = ({ syntaxes }: Props) =>
  syntaxes.length ? (
    <>
      {syntaxes.map((s: Syntax, i: number) =>
        s.description || s.url ? (
          <Popover title={s.name} content={PopoverContent(s)} key={i}>
            <Tag>{s.name}</Tag>
          </Popover>
        ) : (
          <Tag key={i}>{s.name}</Tag>
        )
      )}
    </>
  ) : null;
