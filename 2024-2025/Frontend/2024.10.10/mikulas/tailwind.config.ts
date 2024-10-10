/* eslint-disable @typescript-eslint/no-explicit-any */
import type { Config } from "tailwindcss";

const config: Config = {
  content: [
    "./pages/**/*.{js,ts,jsx,tsx,mdx}",
    "./components/**/*.{js,ts,jsx,tsx,mdx}",
    "./app/**/*.{js,ts,jsx,tsx,mdx}",
  ],
  theme: {
    extend: {
      colors: {
        background: "var(--background)",
        foreground: "var(--foreground)",
      },
    },
  },
  plugins: [
    function ({
      addBase,
    }: {
      addBase: (baseStyles: Record<string, any>) => void;
    }) {
      addBase({
        input: {
          "@apply border-[1.5px] border-gray-400": {},
        },
      });
    },
  ],
};
export default config;
