import { Button, ButtonProps } from "antd";

interface Props extends ButtonProps {
  children: React.ReactNode;
}

export const ButtonAnchorToExternal = ({ children, ...rest }: Props) => (
  <Button {...rest} target="_blank" rel="noopener noreferrer">
    {children}
  </Button>
);
