import { FileJson2 } from "lucide-react";

export function ApiLink() {
  return (
    <div className="text-sm sm:text-base">
      <a
        className="flex items-center gap-2 hover:underline hover:underline-offset-4"
        href="https://api.filterlists.com/"
        target="_blank"
        rel="noopener noreferrer"
      >
        <FileJson2 width={16} height={16} />
        API
      </a>
    </div>
  );
}
