import { Syntax } from "@/src/interfaces";
import { Tag } from "antd";
import { TagWithPopover } from "./TagWithPopover";

interface Props {
  syntaxes: Syntax[];
}

export const SyntaxTags = ({ syntaxes }: Props) =>
  syntaxes.length ? (
    <>
      {syntaxes.map((syntax: Syntax, index: number) =>
        syntax.description || syntax.url ? (
          <TagWithPopover syntax={syntax} key={index} />
        ) : (
          <Tag key={index}>{syntax.name}</Tag>
        )
      )}
    </>
  ) : null;
