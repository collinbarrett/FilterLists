import { Tag } from "antd";

const Copyright = () => (
  <Tag>
    <a
      href="https://collinmbarrett.com"
      title="Collin M. Barrett's Homepage"
      target="_blank"
      rel="noopener noreferrer"
    >
      ©{new Date().getFullYear()}&nbsp; Collin M. Barrett
    </a>
  </Tag>
);
export default Copyright;
