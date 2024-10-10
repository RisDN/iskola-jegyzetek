import type { Metadata } from "next";
import "./globals.css";

export const metadata: Metadata = {
	title: "Mikulás Látogatási Kérelem",
	description: "Kérje a Mikulás látogatását!",
};

export default function RootLayout({
	children,
}: Readonly<{
	children: React.ReactNode;
}>) {
	return (
		<html lang="hu">
			<body className={`antialiased px-16 text-red-900`}>
				{children}
			</body>
		</html>
	);
}
