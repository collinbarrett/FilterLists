import { Syntax } from "@/src/interfaces";
import { Popover, Tag } from "antd";
import { PopoverContent } from "./PopoverContent";
import { AnchorToExternal } from "@/src/components";

interface Props {
  syntaxes: Syntax[];
}

export const SyntaxTags = ({ syntaxes }: Props) =>
  syntaxes.length ? (
    <>
      {syntaxes.map((syntax: Syntax, index: number) =>
        syntax.description || syntax.url ? (
          <Popover
            title={syntax.name}
            content={PopoverContent(syntax)}
            key={index}
          >
            <Tag>
              {syntax.url ? (
                <AnchorToExternal
                  href={syntax.url}
                  title={`View ${syntax.name}'s homepage.`}
                >
                  {syntax.name}
                </AnchorToExternal>
              ) : (
                syntax.name
              )}
            </Tag>
          </Popover>
        ) : (
          <Tag key={index}>{syntax.name}</Tag>
        )
      )}
    </>
  ) : null;
