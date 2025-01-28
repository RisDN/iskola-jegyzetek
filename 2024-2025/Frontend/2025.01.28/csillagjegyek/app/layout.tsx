import type { Metadata } from "next";
import { Geist, Geist_Mono } from "next/font/google";
import "./globals.css";
import { CsillagjegyProvider } from "./providers/CsillagjegyProvider";

const geistSans = Geist({
	variable: "--font-geist-sans",
	subsets: ["latin"],
});

const geistMono = Geist_Mono({
	variable: "--font-geist-mono",
	subsets: ["latin"],
});

export const metadata: Metadata = {
	title: "Csillagjegyek",
	description: "Csillagjegyek api feladat",
};

export default function RootLayout({
	children,
}: Readonly<{
	children: React.ReactNode;
}>) {
	return (
		<CsillagjegyProvider>
			<html lang="hu">
				<body
					className={`${geistSans.variable} ${geistMono.variable} antialiased px-12 bg-slate-400`}
				>
					{children}
				</body>
			</html>
		</CsillagjegyProvider>

	);
}
